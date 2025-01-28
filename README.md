Đề bài:
Give the world database script as attachment, import it to the database then create an application for discovering the database.
On the server side: create SOAP services to expose the data as the following description.
Get all countries from the database.
Get country by country code.
Get the city by name.
Get all cities of a specific country.
And other services that you can think of.
Client side:
Create a windows form application for invoking the server side services.


Kết quả bài tập SOAP Web Service

**Giới thiệu:
Vì sinh viên chưa học đến lập trình WinForms nên chưa thể hoàn thành bài tập trọn vẹn. Tuy nhiên, em cam kết sẽ tận dụng thời gian trong kỳ nghỉ Xuân để học tập thêm về mảng này và hoàn thiện bài tập sau.

Cài đặt Server Side
1. Cài đặt Visual Studio và các thành phần cần thiết:
+ Cài đặt .NET Framework và các template cần thiết trong Visual Studio để xây dựng SOAP Web Service.
+ Chạy Visual Studio Installer -> Chọn Modify -> Các thành phần riêng -> Chọn ".Net framework project and item template".
2.Tạo dự án:
+ Tạo một dự án "ASP.NET Web Application (.NET Framework)".
+ Tạo một Web Service (ASMX) trong dự án mới.
3. Chạy ứng dụng lần đầu:
+ Sau khi tạo xong, chạy ứng dụng và tin tưởng chứng chỉ SSL của IIS Express. Dự án sẽ tạo ra một Web Service cơ bản.
4. Sửa đổi mã nguồn:
+ Bổ sung các tính năng theo yêu cầu đề bài
+ Sinh viên chủ động bổ sung thêm tính năng đếm thành phố theo quốc gia
5. Kết quả thu được:
+ Sau khi sửa mã nguồn và thêm chức năng đếm thành phố, người dùng có thể nhận dữ liệu từ cơ sở dữ liệu MariaDB và trả về dưới dạng SOAP.
+ Các phương thức đều hoạt động chính xác, trả về danh sách các thành phố, quốc gia và các thông tin liên quan.
+  Cài đặt Client Side
Tạo ứng dụng WinForms:
+ Tạo một ứng dụng WinForms để gọi Web Service từ phía client.
