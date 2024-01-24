
using ConsoleApp3;

using (MyApplicationContext context = new MyApplicationContext())
{
    foreach (Phone item in context.Phones)
    {
        Console.WriteLine(item);
    }

    context.Phones.Add(new Phone() { model = "test"});
    context.SaveChanges();

    foreach (Phone item in context.Phones)
    {
        Console.WriteLine(item);
    }
    int idForUpdate = 5;
    var oldData = context.Phones.FirstOrDefault(x => x.id == idForUpdate);
    oldData.model = "New model";
    context.Phones.Update(oldData);
    context.SaveChanges();
    foreach (Phone item in context.Phones)
    {
        Console.WriteLine(item);
    }
    int idForRemove = 5;
    context.Phones.Remove(context.Phones.FirstOrDefault(x => x.id.Equals(idForRemove)));
    context.SaveChanges();
    foreach (Phone item in context.Phones)
    {
        Console.WriteLine(item);
    }

}