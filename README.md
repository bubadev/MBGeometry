# SQL Task

Тут нам необходимы три таблицы:
1. Таблица продуктов
2. Таблица категорий
3. Таблица связи продукта и категории


        select p.Name as ProductName, c.Name as CategoryName
        from Product p
        left join ProductCategory pc on p.ID = pc.ProductID
        left join Category c on pc.CategoryID = c.ID
