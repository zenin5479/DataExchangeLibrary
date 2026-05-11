using ClassLibrary;

namespace WinFormsApp
{
   // PersonEditDialog можно удалить, используя PersonInputDialog с параметром
   public class PersonEditDialog : PersonInputDialog
   {
      public PersonEditDialog(Person person) : base(person) { }
   }
}