
<div dir="rtl">


  
نام پترن: Observer
<br>
هدف : الگوی Observer برای سیستم‌هایی مناسب است که نیاز به اطلاع‌رسانی تغییرات به بخش‌های مختلف دارند، به‌ویژه در سیستم‌هایی که از چندین کاربر یا سرویس متفاوت استفاده می‌شود. این الگو به شما امکان می‌دهد تا از به‌روزرسانی‌های خودکار و همگام‌سازی مؤثر در سیستم‌های پیچیده بهره‌برداری کنید. سناریوهای استفاده:<br>
1. رابطه "یک به چند"<br>
زمانی که یک شیء باید تغییرات خود را به چندین شیء مختلف اطلاع دهد.<br>
مثال: در یک سیستم ایمیل، وقتی که کاربری ایمیل جدیدی ارسال می‌کند، سیستم باید تمام اعضای گروه یا دریافت‌کنندگان را از طریق ایمیل جدید مطلع کند.<br>

2. رابطه بین ویو و مدل در معماری MVC
   <br>
استفاده از Observer برای به‌روز نگه‌داشتن نمایش (View) هنگام تغییرات در مدل (Model).<br>
مثال: در برنامه‌های MVC، زمانی که داده‌ها در مدل تغییر می‌کنند، ویو باید به‌طور خودکار به‌روزرسانی شود بدون نیاز به دخالت کاربر.<br>



<br>
</div>

✅ جمع‌بندی
🔹 بدون Observer Pattern:

کلاس‌ها به شدت به یکدیگر وابسته‌اند.
اضافه کردن ویژگی‌های جدید سخت است.
تست‌پذیری و توسعه‌پذیری پایین است.
🔹 با Observer Pattern:

وابستگی بین کلاس‌ها کاهش یافته است.
افزودن قابلیت‌های جدید بدون تغییر در کد اصلی امکان‌پذیر است.
مقیاس‌پذیری و تست‌پذیری کد بهتر شده است.
✨ این پترن زمانی کاربرد دارد که نیاز باشد چندین شیء از تغییرات یک شیء مطلع شوند، مانند سیستم‌های نوتیفیکیشن، رویدادهای ورود کاربر، یا تغییرات در موجودی کالا.
