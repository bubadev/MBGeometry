# SQL Task

Тут нам необходимы три таблицы:
1)Таблица продуктов
2)Таблица категорий
3)Таблица связи продукта и категории


    select p.Name, c.Name from Products p
    left join ProductCategory pc on p.ID = pc.ProductID
    left join Categories c on pc.CategoryID = c.ID