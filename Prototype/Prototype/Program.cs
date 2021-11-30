// See https://aka.ms/new-console-template for more information
using Prototype;
Menu menu = new Menu();
menu["Eros"] = new Sandwich("eros", "beef", "yelow", "carot");
menu["MIky"] = new Sandwich("eros", "pork", "yelow", "carot");
menu["vIky"] = new Sandwich("eros", "chikend", "yelow", "carot");
Sandwich sandwich1 = menu["Eros"].Clone() as Sandwich;
