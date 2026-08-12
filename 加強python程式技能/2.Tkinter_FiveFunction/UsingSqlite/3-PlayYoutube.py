import yt_dlp
import vlc
import time

# YouTube URL
url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ"  # ← 替換成你自己的網址

# 取得影片 direct stream URL（不下載）
ydl_opts = {
    'format': 'bestaudio/best',
    'quiet': True,
    'noplaylist': True,
}
with yt_dlp.YoutubeDL(ydl_opts) as ydl:
    info = ydl.extract_info(url, download=False)
    video_url = info['url']

# 使用 VLC 播放串流音樂 / 影片
player = vlc.MediaPlayer(video_url)
player.play()

# 確保不會立刻結束程式（等待 VLC 播放完成）
duration = info.get("duration", 0)  # 秒數
time.sleep(duration if duration > 0 else 600)  # 最多等 10 分鐘
