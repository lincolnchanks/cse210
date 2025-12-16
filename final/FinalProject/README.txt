Welcome to Smart Storage!

This program lets you keep track of items in your food storage. The program opens with a 
menu that allows you to take nine (9) different actions.

ACTION 1: ADD ITEM TO STORAGE
Select this to add one item of food to your storage. The program will ask for essential info
such as its name, expiration date, etc. This item will be added to the program's overall
storage.

ACTION 2: LIST ITEMS AND RECIPES
This action will list each item in your storage with its expiration date and number of 
servings. It will also list each recipe saved in the program (see action 5).

ACTION 3: SAVE ALL DATA
This action will save all data into a file, the name of which is specified by the user.
The program will store each item in storage, each recipe, and each scheduled meal.

ACTION 4: LOAD DATA FROM FILE
This action will load all data from a file the user selects and populate the program with it.
In the program's current state it should be able to load all necessary data that was saved 
in the proper format from action 3.

ACTION 5: MAKE RECIPE
This action allows the user to make a recipe--a list of ingredients and amounts that they 
can use to template meals from in the future (see action 7).

ACTION 6: CHECK CALENDAR
This action displays the next 14 days of the month for the user to see. Each day will 
display with each item expiring on that day and each meal scheduled for that day (see action 
7).

ACTION 7: SCHEDULE MEAL
This action creates a "Meal" and lets the user schedule it for a particular day. This Meal 
must be templated from an existing recipe.

ACTION 8: SERVE MEAL
Selecting this will provide the user an option menu of each scheduled meal in the program. 
The user can select one of these to "serve", representing that they have prepared and eaten 
the ingredients required for that meal. These ingreidents will be removed from the storage
based on the number of servings of them used in the meal's recipe.

ACTION 9: QUIT
Quits the program.

NOTE ON INHERITANCE AND POLYMORPHISM
In designing this program I saw no way to include Inheritance or Polymorphism in the design. 
Many classes contained objects of other classes (Has-A), but none were similar enough to 
others in design or purpose (Is-A) to justify being derived from one another. Some classes 
came close to this requirement--for example, I considered making the Meal class derive from 
the Recipe class, but I realized it would not make sense. A Meal is *not* a Recipe, so there 
is no Is-A relationship. Similarly, a Calendar is *not* a Day, it simply has many Days--thus 
that idea was out too.

Since there was no use of Inheritance in this program, I also saw no means of including 
Polymorphism in the design, given that Polymorphism requires the use of Inheritance, which 
itself was not used in the program design.