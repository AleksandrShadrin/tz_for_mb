SELECT
	p.[Имя продукта],
	c.[Имя категории]
FROM [продукты] as p
LEFT JOIN [продукт-категория] as pc ON pc.[ID_product] = p.[ID]
LEFT JOIN [категории] as c ON c.[ID] = pc.[ID_category];