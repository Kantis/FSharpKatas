namespace PrimeSieve

open System

// ---------------------------------------------------------------
//         Algorithm description expressed in pseudocode 
//  Taken from http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
// ---------------------------------------------------------------

//    Input: an integer n > 1
//     
//    Let A be an array of Boolean values, indexed by integers 2 to n,
//    initially all set to true.
//     
//     for i = 2, 3, 4, ..., not exceeding √n:
//      if A[i] is true:
//        for j = i^2, i^2+i, i^2+2i, ..., not exceeding n :
//          A[j] := false
//     
//    Output: all i such that A[i] is true.

module Siever =

    /// <summary>
    /// Returns all primes up to x
    /// </summary>
    let Sieve x : int[] =
        // I create the array from 0 instead of 2 so indexing will be easy
        let A = [| for i in 0..x do 
                    yield true |]

        for i in 2..int(sqrt(float x)) do
            if A.[i] then
                for j in [for k in 0..(x - i*i)/i -> (k*i+i*i)] do
                    A.[j] <- false                    
        
        [| for i in 2..x do
            if A.[i] then
             yield i |]
