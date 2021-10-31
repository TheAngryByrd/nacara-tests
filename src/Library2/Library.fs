namespace Library2

module Say =
    open System
    /// <summary>
    /// This is colors
    /// </summary>
    [<RequireQualifiedAccess>]
    [<Obsolete>]
    type Colors =
    | Red
    | Blue
    | Green
    | Other of char

    open Newtonsoft.Json.Linq
    /// <summary>
    /// This says goodbye to a name
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    let goodbye name =
        printfn "Hello %s" name

    /// <summary>
    /// Creates a JToken
    /// </summary>
    /// <param name="o"></param>
    /// <returns></returns>
    let sendAsJson (o : obj) =
        JToken.FromObject o

    /// <summary>
    /// Adds two integers <paramref name="a"/> and <paramref name="b"/> and returns the result. 
    /// Testing langword: <see langword="string"/>.
    /// Testing method reference : <see cref="M:Microsoft.FSharp.Core.Operators.compare"/>.
    /// </summary>
    ///
    /// <remarks>
    /// This usually contains some really important information that you'll miss if you don't read the docs.
    /// </remarks>
    ///
    /// <param name="a">An integer.</param>
    /// <param name="b">An integer.</param>
    ///
    /// <returns>
    /// The sum of two integers.
    /// </returns>
    /// 
    /// <example>
    /// This shows how to add
    /// <code>
    ///     let foo = add 1 2
    ///     printfn $"{foo}"
    /// </code>
    /// </example>
    ///
    /// <exceptions cref="M:System.OverflowException">Thrown when one parameter is max
    /// and the other is greater than 0.</exceptions>
    let add a b = a + b