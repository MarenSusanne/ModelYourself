namespace ParProgramering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Bjarne = new Person("Bjarne", "42", "brown", "fishing", "beer");
            Console.WriteLine($"Name: {Bjarne.Name}\nAge: {Bjarne.Age}\nHaircolor: {Bjarne.HairColor}\nHobby: {Bjarne.Hobby}\nFavorite meal: {Bjarne.FavoriteMeal}");
            var Kurt = new Person("Kurt", "38", "black", "football", "hot dogs");
            Console.WriteLine($"Name: {Kurt.Name}\nAge: {Kurt.Age}\nHaircolor: {Kurt.HairColor}\nHobby: {Kurt.Hobby}\nFavorite meal: {Kurt.FavoriteMeal}");

            Console.WriteLine("Enter Name:");
            var personName = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            var personAge = Console.ReadLine();
            Console.WriteLine("Enter Hair Color:");
            var personHairColor = Console.ReadLine();
            Console.WriteLine("Enter Hobby:");
            var personHobby = Console.ReadLine();
            Console.WriteLine("Enter Favorite Meal:");
            var personFavoriteMeal = Console.ReadLine();
            var newPerson = new Person($"{personName}", $"{personAge}", $"{personHairColor}", $"{personHobby}", $"{personFavoriteMeal}");
            Console.WriteLine($"Name: {newPerson.Name}\nAge: {newPerson.Age}\nHaircolor: {newPerson.HairColor}\nHobby: {newPerson.Hobby}\nFavorite meal: {newPerson.FavoriteMeal}");
        }
    }
}
