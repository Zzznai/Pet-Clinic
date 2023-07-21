using System.Collections.Generic;
using System.Linq;
using PetClinicApp.Models;

public class AnimalService
{
    private readonly ClinicContextDb ctx;

    public AnimalService(ClinicContextDb context)
    {
        ctx = context;
    }

    public void AddAnimal(Animal animal)
    {
        ctx.Animals.Add(animal);
        ctx.SaveChanges();
    }

    public Animal GetAnimal(int id)
    {
        return ctx.Animals.FirstOrDefault(a => a.Id == id);
    }

    public List<Animal> GetAllAnimals()
    {
        return ctx.Animals.ToList();
    }

    public void UpdateAnimal(Animal animal)
    {
        ctx.Animals.Update(animal);
        ctx.SaveChanges();
    }

    public void DeleteAnimal(int id)
    {
        var animal = ctx.Animals.FirstOrDefault(a => a.Id == id);
        if (animal != null)
        {
            ctx.Animals.Remove(animal);
            ctx.SaveChanges();
        }
    }
}