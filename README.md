# F# Mutable Variable Unexpected Behavior

This example demonstrates a potential issue with mutable variables in F#. The `add` function calculates the sum of two mutable variables. However, if the mutable variables are modified after the initial calculation, the function does not reflect these changes and continues to return the result of the initial calculation.