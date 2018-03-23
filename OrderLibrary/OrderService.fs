namespace OrderLibrary

module OrderService =
    let strategyFactory price = 
        match (price > 1000.0) with
        | true  -> PriceStrategy.rebateStrategy
        | false -> PriceStrategy.discountStrategy 0.8
    
    let getPrice price =
        price
        |> strategyFactory price
