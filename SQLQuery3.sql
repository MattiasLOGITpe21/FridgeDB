SELECT FoodInTheFridge.Name, TypeName.FoodTypeName FROM TypeName
JOIN FoodInTheFridge ON FoodInTheFridge.TypeId = TypeName.Id
Where TypeName.FoodTypeName LIKE 'Fish and Seafood'