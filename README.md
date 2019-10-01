|Behavior|Input|Output|
|--|--|--|
|input values exactly equivalent to the allergen score return the allergen| 2 | peanuts|
|non-integer values are not accepted| U | user error |
|negative integer values are converted to positive| -8 | 8 |
|input values whose total is the sum of multiple allergin values return the applicable allergen names|3|eggs, peanuts|
|input values that exceed the table's rubric, return placeholder references for unknown allergeies and continue as normal|257|unknown allergen, eggs|