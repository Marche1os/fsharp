module lesson_43.task

// 43.3
let try_find key m =
    match (key, m) with
    | (k, map) when Map.containsKey k map -> Some(Map.find k map)
    | (k, map) -> None