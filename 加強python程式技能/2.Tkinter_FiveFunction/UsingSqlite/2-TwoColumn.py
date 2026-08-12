import tkinter as tk
from tkinter import ttk

root = tk.Tk()

# 設定視窗大小與置中位置
window_width = 800
window_height = 400
screen_width = root.winfo_screenwidth()
screen_height = root.winfo_screenheight()
x = int((screen_width - window_width) / 2)
y = int((screen_height - window_height) / 2)
root.geometry(f"{window_width}x{window_height}+{x}+{y}")

# 左框架
left_frame = tk.Frame(root, width=400, height=400, bg='lightgray')
left_frame.pack(side='left', fill='both', expand=True)
left_frame.pack_propagate(False)

# 右框架
right_frame = tk.Frame(root, width=400, height=400, bg='white')
right_frame.pack(side='right', fill='both', expand=True)
right_frame.pack_propagate(False)

# 左邊 Treeview
left_tree = ttk.Treeview(left_frame)
left_tree.pack(fill='both', expand=True)
left_tree.heading('#0', text='左邊樹狀圖')
left_tree.insert('', 'end', text='項目 A')
left_tree.insert('', 'end', text='項目 B')

# 右邊 Treeview
right_tree = ttk.Treeview(right_frame)
right_tree.pack(fill='both', expand=True)
right_tree.heading('#0', text='右邊樹狀圖')
right_tree.insert('', 'end', text='項目 1')
right_tree.insert('', 'end', text='項目 2')

root.mainloop()
