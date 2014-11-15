namespace KarateChop

module Chopper =
    let rec Chop (needle:int, haystack:int[]) : int =
        if haystack = null || haystack.Length = 0 then
            -1
        else
            let len = haystack.Length
            let middle = len/2

            if len = 1 then
                if haystack.[0] = needle then
                    0
                else
                    -1
            else
                if haystack.[middle] = needle then
                    middle
                else if haystack.[middle] < needle then
                    middle + 1 + Chop(needle, haystack.[middle+1 .. len-1])
                else
                    Chop(needle, haystack.[0 .. middle-1])
                    
