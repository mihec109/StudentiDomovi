Create Procedure spDeleteUporabniki
@Email nvarchar(30)
as
Begin
  Delete from Uporabniki where Email = @Email
End