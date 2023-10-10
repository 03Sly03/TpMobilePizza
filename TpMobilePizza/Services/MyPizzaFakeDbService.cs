using TpMobilePizza.Models;
using System.Linq.Expressions;
using System;

namespace TpMobilePizza.Services
{
    public class MyPizzaFakeDbService : IMyPizzaService
    {
        private List<MyPizza> _myPizzas;
        private int _lastIndex = 0;

        public MyPizzaFakeDbService()
        {
            _myPizzas = new List<MyPizza>()
            {
                new MyPizza{ Id =++_lastIndex, Name ="Bacon", Price = 12, Ingredients = new List<Ingredient>() {
                    new () {Id = 1, PizzaId = 1, Name = "bacon"},
                    new () {Id = 2, PizzaId = 1, Name = "mozzarella"},
                    new () {Id = 3, PizzaId = 1, Name = "champignon"},
                    new () {Id = 4, PizzaId = 1, Name = "emmental"},
                    new () {Id = 5, PizzaId = 1, Name = "emmental"}
                }, PicturePath = "/images/bacon.jpg"  },
                new MyPizza{ Id =++_lastIndex, Name ="4 fromages", Price= 11, Ingredients = new List<Ingredient>() {
                    new () {Id = 1, PizzaId = 1, Name = "cantal"},
                    new () {Id = 2, PizzaId = 1, Name = "mozzarella"},
                    new () {Id = 3, PizzaId = 1, Name = "fromage de chèvre"},
                    new () {Id = 4, PizzaId = 1, Name = "gruyère"}
                }, PicturePath = "/images/cheese.jpg"},
                new MyPizza{ Id =++_lastIndex, Name ="Margherita", Price = 10, Ingredients = new List<Ingredient>() {
                    new () {Id = 1, PizzaId = 1, Name = "sauce tomate"},
                    new () {Id = 2, PizzaId = 1, Name = "mozzarella"},
                    new () {Id = 3, PizzaId = 1, Name = "basilic"}
                }, PicturePath = "/images/margherita.jpg"},
                new MyPizza{ Id =++_lastIndex, Name ="Mexicaine", Price=12, Ingredients = new List<Ingredient>() {
                    new () {Id = 1, PizzaId = 1, Name = "boeuf"},
                    new () {Id = 2, PizzaId = 1, Name = "mozzarella"},
                    new () {Id = 3, PizzaId = 1, Name = "maïs"},
                    new () {Id = 4, PizzaId = 1, Name = "tomates"},
                    new () {Id = 5, PizzaId = 1, Name = "oignon"},
                    new () {Id = 6, PizzaId = 1, Name = "coriandre"}
                }, PicturePath = "/images/meaty.jpg"},
                new MyPizza{ Id =++_lastIndex, Name ="Reine", Price=11, Ingredients = new List<Ingredient>() {
                    new () {Id = 1, PizzaId = 1, Name = "jambon"},
                    new () {Id = 2, PizzaId = 1, Name = "champignons"},
                    new () {Id = 3, PizzaId = 1, Name = "mozzarella"}
                }, PicturePath = "/images/mushroom.jpg"},
                new MyPizza{ Id =++_lastIndex, Name ="Pepperoni", Price=11, Ingredients = new List<Ingredient>() {
                    new () {Id = 1, PizzaId = 1, Name = "pepperoni"},
                    new () {Id = 2, PizzaId = 1, Name = "mozzarella"},
                    new () {Id = 3, PizzaId = 1, Name = "tomates"}
                }, PicturePath = "/images/pepperoni.jpg"},
                new MyPizza{ Id =++_lastIndex, Name ="Végétarienne",Price = 10, Ingredients = new List<Ingredient>() {
                    new () {Id = 1, PizzaId = 1, Name = "champignons"},
                    new () {Id = 2, PizzaId = 1, Name = "roquette"},
                    new () {Id = 3, PizzaId = 1, Name = "artichauts"},
                    new () {Id = 4, PizzaId = 1, Name = "aubergine"}
                }, PicturePath = "/images/veggie.jpg"},
            };
        }
        public List<MyPizza> GetAll()
        {
            return _myPizzas;
        }

        public MyPizza GetById(int id)
        {
            return _myPizzas.FirstOrDefault(c => c.Id == id);
        }



        public void Post(MyPizza myPizza)
        {
            myPizza.Id = ++_lastIndex;
            _myPizzas.Add(myPizza);
        }

        public void Update(MyPizza myPizza)
        {
            var pizzaFromDb = GetById(myPizza.Id);
            if (pizzaFromDb != null)
            {
                if (pizzaFromDb.Name != myPizza.Name)
                    pizzaFromDb.Name = myPizza.Name;
                if (pizzaFromDb.Ingredients != myPizza.Ingredients)
                    pizzaFromDb.Ingredients = myPizza.Ingredients;
                if (pizzaFromDb.Price != myPizza.Price)
                    pizzaFromDb.Price = myPizza.Price;
                if (pizzaFromDb.PicturePath != myPizza.PicturePath)
                    pizzaFromDb.PicturePath = myPizza.PicturePath;
            }
        }

        public bool Delete(int id)
        {
            var myPizza = GetById(id);
            if (myPizza == null)
                return false;
            _myPizzas.Remove(myPizza);
            return true;
        }

        public MyPizza GetById(Expression<Func<MyPizza, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<MyPizza> GetAll(Expression<Func<MyPizza, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }

}
