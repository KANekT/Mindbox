select p.title, c.title from mid.products p
left join mid.product_category cp on p.id = cp.prod_id
left join mid.categories c on c.id = cp.cat_id