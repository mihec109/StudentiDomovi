    create procedure Uporabniki_Add  
@Username  nvarchar(30),  
 @Password nvarchar(30),  
 @Email nvarchar(30)
 AS  
 BEGIN  
 Insert into Uporabniki(Username,Password,Email)  
 values(@Username,@Password,@Email)  
 END 
