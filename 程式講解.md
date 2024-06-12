程式講解 :  
   粉色按鍵是利用 timer1 控制，按下對應按鍵後會觸發，並將  visuable 變成 false 0.1 秒，再恢復成 true。(流程圖1)
  花瓣下落是利用 timer2控制，每次以 5 單位距離下落，並在落到底部時透過 Random 出現在不同的位置。
(流程圖2)
  計分是透過 timer3 控制，寫一個 hit 函式，在花瓣落到粉色方塊以外的地方會回傳 false，否則回傳 true ，而在粉色按鍵  visuable  是 true 以及 hit  函式回傳 true時，if  才會成立，score  加一分並將圖片 visuable 改為false。(流程圖3)
