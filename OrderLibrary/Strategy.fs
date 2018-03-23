namespace OrderLibrary

module PriceStrategy =
    let rebateStrategy price = price - 100.0
    let discountStrategy discount price = price * discount * 1.0