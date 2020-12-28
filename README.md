<div dir='rtl' lang='he'>

# מטלה 9 שבועית
את כל השינויים בקוד עשינו על הסצנה a-charactercontroller

    1 .תזוזה: בחרו אפשרות אחת-
    א': הוסיפו לשחקן את האופציה לקפוץ. כאשר נלחץ על המקש הארוך, השחקן יקפוץ.

https://github.com/Noa-Amit/task-9-terrain/blob/main/Assets/Scripts/1-player/CharacterKeyboardMover.cs

לקחנו את הסקריפט מהשיעור והוספנו לו כמה שורות.אם נלחץ כפתור הרווח השחקן הזז כלפי מעלה על ציר ה-Y

    2 .נשק: בחרו אפשרות אחת -
    ד': תמיד רציתם כוח על משלכם! צרו כמה אובייקטים קטנים בסביבה הקיימת. כעת צרו raycast שכאשר הוא פוגע
    באחד מהאובייקטים הללו, השחקן יוכל להזיז את האובייקט ממקום למקום.

יצרנו 3 קוביות חומות שעליהן הקוד עובד. הוספנו לשחקן סקריפט חדש שבו נשלחת קרן לייזר קדימה כשהשחקן לוחץ על E
אם הקרן פוגעת בקוביה, ניתן להזיז את הקוביה למשך כמה שניות בעזרת הלחצנים y g h j

https://github.com/Noa-Amit/task-9-terrain/blob/main/Assets/Scripts/1-player/RayCast.cs

![WhatsApp Image 2020-12-28 at 14 52 45](https://user-images.githubusercontent.com/57709369/103215700-c81a2280-491c-11eb-8b83-50240ffd385f.jpeg)


    3 .אינטראקציה : בחרו אופציה אחת-
    ב': צרו דמות כלשהי, כאשר נלחץ לידה על כפתור E ,היא תגיד !Hey ,או שיהיה רשום !Hey על המסך. 
יצרנו קוביה צהובה שעושה את הפעולה הזו. הוספנו לה סקריפט שבודק אם השחקן קרוב אליו וגם E לחוץ אז רואים את הטקסט

https://github.com/Noa-Amit/task-9-terrain/blob/main/Assets/Scripts/1-player/sayHello.cs

![WhatsApp Image 2020-12-28 at 14 53 59](https://user-images.githubusercontent.com/57709369/103215716-d8320200-491c-11eb-9f8b-04f2be07cfaf.jpeg)
