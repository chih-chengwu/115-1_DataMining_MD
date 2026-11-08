import pandas as pd
import numpy as np
from sklearn.preprocessing import StandardScaler
from sklearn.linear_model import LogisticRegression
from sklearn.tree import DecisionTreeClassifier
from sklearn.ensemble import RandomForestClassifier
from sklearn.metrics import accuracy_score, classification_report

# 1. 建立資料集
data = {
    'Age': [58, 30, 37, 70, 40, 27, 39, 52, 61, 44, 62, 18, 16, 18, 71, 60, 46, 58, 
            48, 46, 47, 36], # 包含最後4筆
    'Income': [9, 6, 12, 12, 5, 7, 13, 6, 8, 14, 17, 5, 0, 12, 2, 8, 9, 9, 
               5, 6, 10, 18], # 包含最後4筆
    'Tour': [1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 
             0, 0, 1, 0]    # 包含最後4筆 (0:沒參加, 1:有參加)
}

df = pd.DataFrame(data)

# 2. 資料切割 (前18筆 Train, 後4筆 Test)
train_df = df.iloc[:18]
test_df = df.iloc[18:]

# 分離特徵 (X) 與 標籤 (y)
X_train = train_df[['Age', 'Income']]
y_train = train_df['Tour']

X_test = test_df[['Age', 'Income']]
y_test_actual = test_df['Tour'] # 這是最後4筆實際的結果，用來對答案

# 3. 資料標準化 (Standardization)
# 注意：Scaler 只能用 X_train 來 fit (學習)，然後同時 transform (轉換) train 和 test
# 這是為了模擬真實情況，避免將測試資料的資訊洩漏給模型
scaler = StandardScaler()
X_train_scaled = scaler.fit_transform(X_train)
X_test_scaled = scaler.transform(X_test)

print("--- 資料預處理完成 ---\n")

# 定義要使用的模型
models = {
    "Logistic Regression (羅吉斯決策樹)": LogisticRegression(random_state=42),
    "Decision Tree (決策樹)": DecisionTreeClassifier(random_state=42, max_depth=3),
    "Random Forest (決策樹)": RandomForestClassifier(n_estimators=100, random_state=42)
}

# 4. 跑迴圈執行三種演算法
for name, model in models.items():
    print(f"正在執行模型: {name}")
    
    # 訓練模型
    model.fit(X_train_scaled, y_train)
    
    # 進行預測
    y_pred = model.predict(X_test_scaled)
    
    # 計算正確率
    acc = accuracy_score(y_test_actual, y_pred)
    
    # 顯示結果
    print(f"1. 預測最後4筆結果 (0=沒參加, 1=參加): {y_pred}")
    print(f"   實際最後4筆結果: {y_test_actual.values}")
    print(f"2. 正確率 (Accuracy): {acc * 100:.1f}%")
    print("-" * 30)