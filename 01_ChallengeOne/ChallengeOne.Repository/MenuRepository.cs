using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//She needs a console app.
    public class Menu_Repository
    // this only exists to store data, MENUDATA (List<Menu> below)
    {
      private readonly List<Menu> _OneRepo = new List<Menu>();
      // ^ This is our database, its fake, but that doesn't manner.
      //                            ^ This is our collection, like a storage container
      //                             ^ FULL C.R.U.D. happens here and here only.
      private int _count = 0;
      //Create

    //The manager wants to be able to create new menu items, 
      public bool AddDeveloperToRepo(Menu menu) //<- 'menu' can literally be named anything. Pass an object of that type into it and then we can do work.
      {
          if(menu != null)
          {
              _count++;
              // count =  count+1 because count defaults to 0 (line 14)
              menu.ID=_count;
              _OneRepo.Add(menu);
              // ^ This adds it to the database
              return true;
              //^ When added it returns true
          }
          else
          {
              return false;
          }
      }
      // and receive a list of all items on the cafe's menu.
      public List<Menu> GetAllIngredients()
      {
          return _OneRepo;
      }
      //Read- Gives and Returns a Meal
      //This is the helper method
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
        var oldMenuData= GetmealNameByID(id);
        if(oldMenuData != null)
        {
            oldMenuData.MealName= newMenuData.MealName;
            oldMenuData.MealDescription= newMenuData.MealDescription;
            oldMenuData.MealIngredients= newMenuData.MealIngredients;
            oldMenuData.MealPrice= newMenuData.MealPrice;
            return true;
        }
        return false;
    }
    //^ Like sorting magic cards into five rows instead of a binder
    // ^Update method is a full clear meaning everything is wiped out and reassigned

    //delete
    // delete menu items, 
    public bool DeleteMenuItemFromRepository(int userInputID)
    {
        var item = GetmealNameByID(userInputID);
        // ^ This is like a bar
        // Beneath is like the requirements to get in
        if(item != null)
        {
            _OneRepo.Remove(item);
            return true;
        }
        else
        {
            return false;
        }
    }

    // public void AddDevTeamToRepo(DevTeam tidebarer)
    // {
    //     throw new NotImplementedException();
    // }
}