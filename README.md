# F# Immutability Gotcha: Unexpected Behavior with Immutable Variables

This example showcases a common pitfall in F#: unintentionally relying on mutability when working with immutable variables by default. In F#, values are immutable unless explicitly declared as mutable using the `mutable` keyword.  The code demonstrates how re-assigning mutable variables doesn't update the value of a variable that has previously used the value of the mutable variables in an expression. 

## How to Reproduce
1. Clone this repo.
2. Open `bug.fs`.
3. Run the code. Observe that even after updating `x` and `y`, the value of `z` remains unchanged. 

## Solution
The `bugSolution.fs` file demonstrates the corrected approach: recalculating `z` whenever `x` or `y` changes. 