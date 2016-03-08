﻿(*
    Exercise 1-7 from Functional Programming Using F#
    Copyright (c) 2016 Răzvan Mocanu

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*)

(*
    Determine a type for each of the expressions:
        1. (System.Math.PI, fact -1)
        2. fact(fact 4)
        3. power (System.Math.PI, fact 2)
        4. (power, fact)
*)

(*
    1. Infinite evaluation
    2. val it: int
    3. val it: float
    4. val it: (float * int -> float) * (int -> int)
*)