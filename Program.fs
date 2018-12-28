
open System

let data = "Sunset is the time of day when our sky meets the outer space solar winds. There are blue, pink, and purple swirls, spinning and twisting, like clouds of balloons caught in a blender. The sun moves slowly to hide behind the line of horizon, while the moon races to take its place in prominence atop the night sky. People slow to a crawl, entranced, fully forgetting the deeds that still must be done. There is a coolness, a calmness, when the sun does set."
let input = data.Split(' ', '\n')
let output = Array.zeroCreate 5
let random = Random()

output.[0] <- input.[random.Next(input.Length)]

let rec main outputIndex =
    let inputIndex = random.Next(input.Length - 1)

    if outputIndex < 4 then
        if input.[inputIndex] = output.[outputIndex] then
            output.[outputIndex + 1] <- input.[inputIndex + 1]
            main (outputIndex + 1)
        else
            main outputIndex
    else
        let outputString = output |> String.concat " "
        printfn "%s" outputString
        Console.Read() |> ignore
main 0
