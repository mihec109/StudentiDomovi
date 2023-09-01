Create Procedure spDeleteStudenti
@Vpisna_stevilka int
as
Begin
  Delete from Studenti where Vpisna_stevilka = @Vpisna_stevilka
End