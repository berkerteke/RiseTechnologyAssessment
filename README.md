# Contact
Iki microserviceten oluşan ve birbirleriyle haberleşen bir telefon rehberi uygulamasıdır.
Rise Technology firması tarafından değerlendirilmek üzere hazırlanmıştır.


# Kullanılan Teknolojiler

- [.NET 6](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-6.0)

- [Entity Framework Core 6](https://docs.microsoft.com/en-us/ef/core/)

- [Docker](https://www.docker.com/)

- [RabbitMQ](https://www.rabbitmq.com/)

- [xUnit](https://xunit.net/)

- [Moq](https://github.com/moq)

- [Coverlet](https://github.com/coverlet-coverage/coverlet)



# Get Started

1) [**PostgreSQL**](https://www.postgresql.org/)'nin ve [**Docker**](https://www.docker.com/)'ın bilgisayarınızda yüklü olduğundan emin olunuz ve aşağıdaki adımlara dikkat ediniz.
	  1. docker run -it --rm --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.9-management
	  2. **Contacts.API** içerisinde bulunan **appsettings.json** dosyasındaki **"ConnectionStrings"** içerisinde bulunan **User ID**, **Password** ve **Host** bilgilerini ve **"Options"** içerisinde bulunan **RabbitMqConnectionString** bilgisini kendinize uygun şekilde düzenleyeniz. kendinize uygun şekilde düzenleyeniz.
      3. **Reports.API** içerisinde bulunan **appsettings.json** dosyasındaki **"ConnectionStrings"** içerisinde bulunan **User ID**, **Password** ve **Host** bilgilerini ve **"Options"** içerisinde bulunan **RabbitMqConnectionString** bilgisini kendinize uygun şekilde düzenleyeniz. kendinize uygun şekilde düzenleyeniz.

   

2.  **Contacts.API** klasörü içerisinde bir **terminal** açıp aşağıdaki komut ile **PhoneBook.API** projesini çalıştırabilirsiniz.

   ```bash
   dotnet run
   ```

3. **Reports.API** klasörü içerisinde bir **terminal** açıp aşağıdaki komut ile **Report.API** projesini çalıştırabilirsiniz.

      ```bash
      dotnet run
      ```








