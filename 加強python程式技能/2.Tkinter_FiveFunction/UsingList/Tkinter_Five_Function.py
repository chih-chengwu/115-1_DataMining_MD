import tkinter as tk
from tkinter import messagebox, simpledialog, filedialog
import csv
import os

# 資料儲存在列表
contacts = []
csv_filename = "contacts.csv"

# 讀取 CSV 檔
def load_contacts():
    if os.path.exists(csv_filename):
        with open(csv_filename, mode='r', newline='', encoding='utf-8') as f:
            reader = csv.DictReader(f)
            for row in reader:
                contacts.append({"姓名": row["姓名"], "電話": row["電話"]})

# 儲存 CSV 檔
def save_contacts():
    with open(csv_filename, mode='w', newline='', encoding='utf-8') as f:
        writer = csv.DictWriter(f, fieldnames=["姓名", "電話"])
        writer.writeheader()
        writer.writerows(contacts)

# 主視窗
root = tk.Tk()
root.title("簡易通訊錄")

# 函數區
def add_contact():
    name = entry_name.get().strip()
    phone = entry_phone.get().strip()
    if name == "" or phone == "":
        messagebox.showwarning("警告", "請填寫姓名和電話號碼")
        return
    contacts.append({"姓名": name, "電話": phone})
    refresh_listbox()
    entry_name.delete(0, tk.END)
    entry_phone.delete(0, tk.END)

def refresh_listbox():
    listbox_contacts.delete(0, tk.END)
    for idx, contact in enumerate(contacts):
        listbox_contacts.insert(tk.END, f"{idx+1}. {contact['姓名']} - {contact['電話']}")

def delete_contact():
    selected = listbox_contacts.curselection()
    if not selected:
        messagebox.showwarning("警告", "請選擇要刪除的項目")
        return
    idx = selected[0]
    contacts.pop(idx)
    refresh_listbox()

def search_contact():
    search_name = simpledialog.askstring("搜尋", "請輸入姓名")
    if search_name:
        results = [f"{c['姓名']} - {c['電話']}" for c in contacts if search_name in c['姓名']]
        if results:
            messagebox.showinfo("搜尋結果", "\n".join(results))
        else:
            messagebox.showinfo("搜尋結果", "查無此人")

def edit_contact():
    selected = listbox_contacts.curselection()
    if not selected:
        messagebox.showwarning("警告", "請選擇要修改的項目")
        return
    idx = selected[0]
    contact = contacts[idx]

    new_name = simpledialog.askstring("修改姓名", "輸入新姓名", initialvalue=contact["姓名"])
    new_phone = simpledialog.askstring("修改電話", "輸入新電話", initialvalue=contact["電話"])
    if new_name and new_phone:
        contacts[idx] = {"姓名": new_name, "電話": new_phone}
        refresh_listbox()

def export_csv():
    if not contacts:
        messagebox.showwarning("警告", "目前沒有資料可以匯出")
        return
    filepath = filedialog.asksaveasfilename(defaultextension=".csv", filetypes=[("CSV files", "*.csv")])
    if filepath:
        with open(filepath, mode='w', newline='', encoding='utf-8') as f:
            writer = csv.DictWriter(f, fieldnames=["姓名", "電話"])
            writer.writeheader()
            writer.writerows(contacts)
        messagebox.showinfo("成功", f"資料已匯出到 {filepath}")

def on_exit():
    save_contacts()
    root.destroy()

# 介面設計
frame_input = tk.Frame(root)
frame_input.pack(pady=10)

label_name = tk.Label(frame_input, text="姓名:")
label_name.grid(row=0, column=0, padx=5)
entry_name = tk.Entry(frame_input)
entry_name.grid(row=0, column=1, padx=5)

label_phone = tk.Label(frame_input, text="電話:")
label_phone.grid(row=0, column=2, padx=5)
entry_phone = tk.Entry(frame_input)
entry_phone.grid(row=0, column=3, padx=5)

btn_add = tk.Button(root, text="新增", command=add_contact)
btn_add.pack(pady=5)

listbox_contacts = tk.Listbox(root, width=50)
listbox_contacts.pack(pady=10)

frame_buttons = tk.Frame(root)
frame_buttons.pack(pady=5)

btn_edit = tk.Button(frame_buttons, text="修改", command=edit_contact)
btn_edit.grid(row=0, column=0, padx=5)

btn_delete = tk.Button(frame_buttons, text="刪除", command=delete_contact)
btn_delete.grid(row=0, column=1, padx=5)

btn_search = tk.Button(frame_buttons, text="搜尋", command=search_contact)
btn_search.grid(row=0, column=2, padx=5)

btn_export = tk.Button(frame_buttons, text="匯出 CSV", command=export_csv)
btn_export.grid(row=0, column=3, padx=5)

btn_exit = tk.Button(root, text="離開", command=on_exit)
btn_exit.pack(pady=5)

# 讀取資料並刷新畫面
load_contacts()
refresh_listbox()

# 關閉視窗時觸發
root.protocol("WM_DELETE_WINDOW", on_exit)

root.mainloop()
