namespace Library1

module Say =
    /// <summary>
    /// This says hello to a name
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    let hello name =
        printfn "Hello %s" name
