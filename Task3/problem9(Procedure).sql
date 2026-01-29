--Views(9)
create proc sp_ApplyCategoryDiscount
@CatID int , @DiscountPercent decimal
as
  update products set price =
  case when price - (price*DiscountPercent/100) < min_price then min_price
  else  price - (price*DiscountPercent/100)
  End
  where category_id = @CatID
 