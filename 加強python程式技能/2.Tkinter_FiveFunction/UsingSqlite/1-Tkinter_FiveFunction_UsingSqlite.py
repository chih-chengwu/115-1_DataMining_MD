import tkinter as tk
from tkinter import ttk, messagebox, simpledialog, filedialog
import sqlite3
import csv
import os

# 資料庫設定
db_name = 'Friend.db'

def init_db():
    conn = sqlite3.connect(db_name)
    cursor = conn.cursor()
    cursor.execute('''
        CREATE TABLE IF NOT EXISTS contacts (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            name TEXT NOT NULL,
            phone TEXT NOT NULL
        )
    ''')
    conn.commit()
    conn.close()

def add_contact(name, phone):
    conn = sqlite3.connect(db_name)
    cursor = conn.cursor()
    cursor.execute('INSERT INTO contacts (name, phone) VALUES (?, ?)', (name, phone))
    conn.commit()
    conn.close()
    refresh_contacts()

def get_all_contacts():
    conn = sqlite3.connect(db_name)
    cursor = conn.cursor()
    cursor.execute('SELECT id, name, phone FROM contacts')
    rows = cursor.fetchall()
    conn.close()
    return rows

def delete_contact(contact_id):
    conn = sqlite3.connect(db_name)
    cursor = conn.cursor()
    cursor.execute('DELETE FROM contacts WHERE id = ?', (contact_id,))
    conn.commit()
    conn.close()
    refresh_contacts()

def update_contact(contact_id, new_name, new_phone):
    conn = sqlite3.connect(db_name)
    cursor = conn.cursor()
    cursor.execute('UPDATE contacts SET name = ?, phone = ? WHERE id = ?', (new_name, new_phone, contact_id))
    conn.commit()
    conn.close()
    refresh_contacts()

def search_contact(name):
    conn = sqlite3.connect(db_name)
    cursor = conn.cursor()
    cursor.execute('SELECT id, name, phone FROM contacts WHERE name LIKE ?', ('%' + name + '%',))
    rows = cursor.fetchall()
    conn.close()
    return rows

def export_contacts():
    contacts = get_all_contacts()
    if not contacts:
        messagebox.showwarning("警告", "沒有資料可以匯出")
        return
    filepath = filedialog.asksaveasfilename(defaultextension=".csv", filetypes=[("CSV files", "*.csv")])
    if filepath:
        with open(filepath, 'w', newline='', encoding='utf-8') as f:
            writer = csv.writer(f)
            writer.writerow(['ID', '姓名', '電話'])
            writer.writerows(contacts)
        messagebox.showinfo("成功", f"資料已匯出到 {filepath}")

def refresh_contacts():
    for row in tree.get_children():
        tree.delete(row)
    for contact in get_all_contacts():
        tree.insert('', tk.END, values=contact)

def on_add():
    name = entry_name.get().strip()
    phone = entry_phone.get().strip()
    if not name or not phone:
        messagebox.showwarning("警告", "姓名和電話不能空白")
        return
    add_contact(name, phone)
    entry_name.delete(0, tk.END)
    entry_phone.delete(0, tk.END)

def on_delete():
    selected = tree.selection()
    if not selected:
        messagebox.showwarning("警告", "請選擇要刪除的資料")
        return
    item = tree.item(selected[0])
    contact_id = item['values'][0]
    # print(item)
    # print(contact_id)
    delete_contact(contact_id)

def on_edit():
    selected = tree.selection()
    if not selected:
        messagebox.showwarning("警告", "請選擇要修改的資料")
        return
    item = tree.item(selected[0])
    contact_id, old_name, old_phone = item['values']

    new_name = simpledialog.askstring("修改姓名", "輸入新姓名", initialvalue=old_name)
    new_phone = simpledialog.askstring("修改電話", "輸入新電話", initialvalue=old_phone)
    if new_name and new_phone:
        update_contact(contact_id, new_name, new_phone)

def on_search():
    search_name = simpledialog.askstring("搜尋", "輸入要搜尋的姓名")
    if search_name:
        results = search_contact(search_name)
        for row in tree.get_children():
            tree.delete(row)
        for contact in results:
            tree.insert('', tk.END, values=contact)

# 主畫面設定
root = tk.Tk()
root.title("簡易通訊錄 (SQLite版)")

# 設定視窗大小與置中位置
window_width = 500
window_height = 400
screen_width = root.winfo_screenwidth()
screen_height = root.winfo_screenheight()
x = int((screen_width - window_width) / 2)
y = int((screen_height - window_height) / 2)
#root.geometry("500x400")  # 設定主視窗大小
root.geometry(f"{window_width}x{window_height}+{x}+{y}")

# 輸入欄位
#frame_input = tk.Frame(root)
frame_input = tk.Frame(root, width=200, height=100)
frame_input.pack(pady=10)
#frame_input.pack_propagate(False)  # 防止自動調整大小

tk.Label(frame_input, text="姓名:").grid(row=0, column=0, padx=5)

entry_name = tk.Entry(frame_input)
entry_name.grid(row=0, column=1, padx=5)

tk.Label(frame_input, text="電話:").grid(row=0, column=2, padx=5)
entry_phone = tk.Entry(frame_input)
entry_phone.grid(row=0, column=3, padx=5)

btn_add = tk.Button(root, text="新增", command=on_add)
btn_add.pack(pady=5)

# 資料表格
columns = ("ID", "姓名", "電話")
tree = ttk.Treeview(root, columns=columns, show='headings')
for col in columns:
    tree.heading(col, text=col)
    tree.column(col, width=100)

tree.pack(pady=10)

# 功能按鈕
# frame_buttons = tk.Frame(root)
frame_buttons = tk.Frame(root, width=200, height=100)
frame_buttons.pack(pady=5)

btn_edit = tk.Button(frame_buttons, text="修改", command=on_edit)
btn_edit.grid(row=0, column=0, padx=5)

btn_delete = tk.Button(frame_buttons, text="刪除", command=on_delete)
btn_delete.grid(row=0, column=1, padx=5)

btn_search = tk.Button(frame_buttons, text="搜尋", command=on_search)
btn_search.grid(row=0, column=2, padx=5)

btn_export = tk.Button(frame_buttons, text="匯出 CSV", command=export_contacts)
btn_export.grid(row=0, column=3, padx=5)

btn_export = tk.Button(frame_buttons, text="Refresh Data", command=refresh_contacts)
btn_export.grid(row=0, column=4, padx=5)

btn_exit = tk.Button(root, text="離開", command=root.quit)
btn_exit.pack(pady=5)

# 初始化資料庫並刷新資料
init_db()
refresh_contacts()

root.mainloop()
