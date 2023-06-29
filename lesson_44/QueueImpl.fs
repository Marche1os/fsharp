module MyQueue

type Queue<'a> = {front: 'a list; rear: 'a list}
let empty = {front = []; rear = []}