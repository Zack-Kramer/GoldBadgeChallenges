using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
    public class Menu_Repository
    {
      private readonly List<Menu> _OneRepo = new List<Menu>();
      private int _count;
      //Create
      public bool AddDeveloperToRepo(Menu menu)
      {
          if(menu != null)
          {
              _count++;
              developer.ID=_count;
              _OneRepo.Add(menu);
              return true;
          }
          else
          {
              return false;
          }
      }
      public List<Menu> GetAllIngredients()
      {
          return _developerRepo;
      }
      //Read- Gives and Returns a Meal
      public Menu GetmealNameByID(int id)
      {
          foreach(var menu in _OneRepo)
          {
              if(menu.ID == id)
              {
                  return menu;
              }
          }
          return null;
      }
    //Update
    public bool UpdateMenu(int id, Menu newMenuData)
    {
        var oldMenuData= GetMenuByID(id);
        if(oldMenuData != null)
        {
            oldMenuData.MealName= newMenuData.mealName;
            oldMenuData.MealDescription= newMenuData.mealDescription;
            oldMenuData.MealIngredients= newMenuData.mealIngredients;
            oldMenuData.MealPrice= newMenuData.mealPrice;
            oldMenuData.HasPluralsight= newMenuData.HasPluralsight;
            return true;
        }
        return false;
    }

    //delete
    public bool DeleteDescriptionfromMenu(int userInputDescriptionID)
    {
        var descriptionToDelete = GetDescriptionByID(userInputDescriptionID);
        if(descriptionToDelete != null)
        {
            _OneRepo.Remove(descToDelete);
            return true;
        }
        return false;
    }

    // public void AddDevTeamToRepo(DevTeam tidebarer)
    // {
    //     throw new NotImplementedException();
    // }
}