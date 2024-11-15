// Tail-recursive function to find the product of all odd numbers from a given number down to 1
// let rec productOddTailRecursive n acc =
//     if n <= 1 then acc  // Base case: if n is 1 or less, return the accumulated product
//     else productOddTailRecursive (n - 2) (acc * n)  // Recursive case: decrement by 2 and multiply by n

// // Sample call for testing the product of odd numbers
// let oddResult = productOddTailRecursive 11 1

// // Print the result
// printfn "The product of all odd numbers from 11 to 1 is: %d" oddResult

// // Sample list for testing
// let numbers = [1; 2; 3; 4; 5]

// // Call the function with the initial accumulator value of 1
// let result = productTailRecursive numbers 1

// // Print the result
// printfn "The product of all the elements in the list is: %d" result

// // Using map to trim a collection of strings
// let names = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]
// let trimmedNames = List.map (fun name -> name.Trim()) names

// // Print the trimmed names
// printfn "Trimmed names: %A" trimmedNames

// // Using filter and reduce with a sequence
// let sequence = [1 .. 700]
// let filteredSequence = sequence |> List.filter (fun x -> x % 7 = 0 && x % 5 = 0)
// let sumOfFiltered = List.fold (+) 0 filteredSequence

// // Print the sum of filtered numbers
// printfn "The sum of all numbers that are multiples of both 7 and 5 is: %d" sumOfFiltered

// // Using filter and reduce with a collection of strings
// let stringList = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]
// let filteredStrings = stringList |> List.filter (fun name -> name.ToLower().Contains('i'))
// let concatenatedNames = List.fold (fun acc name -> acc + name) "" filteredStrings

// // Print the concatenated names
// printfn "Concatenated names containing 'i': %s" concatenatedNames
