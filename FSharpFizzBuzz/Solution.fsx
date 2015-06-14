let FizzBuzz number = number.ToString()

let FizzBuzz number = 
    if number % 3 = 0 && number % 5 = 0 then "FizzBuzz"
    else if number % 3 = 0 then "Fizz"
    else if number % 5 = 0 then "Buzz"
    else number.ToString()

let FizzBuzz number = 
    match number with
    | i when i % 3 = 0 && i % 5 = 0 -> "FizzBuzz"
    | i when i % 3 = 0 -> "Fizz"
    | i when i % 5 = 0 -> "Buzz"
    | _ -> number.ToString()

FizzBuzz 1
FizzBuzz 2
FizzBuzz 3
FizzBuzz 5
FizzBuzz 15

let firstHundred = [1..100] 
firstHundred|> List.map FizzBuzz
firstHundred |> List.map FizzBuzz |> List.reduce (sprintf "%s\r\n%s")

#r @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\WPF\System.Speech.dll"
open System.Speech.Synthesis
let synth = new SpeechSynthesizer()
synth.Speak "Good morning Cellenza"
synth.SelectVoiceByHints(VoiceGender.Female);
synth.Speak "Hello, and again welcome to the Aperture Science computer-aided enrichment center"
synth.Rate = 20

[1..15] |> List.map FizzBuzz |> List.map synth.Speak 