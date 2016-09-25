﻿(*
    Exercise 4-13 from Functional Programming Using F#
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

let rec minimum = function
    | x :: xs ->
        match minimum xs with
        | Some m when x < m -> Some x
        | Some m -> Some m
        | None -> Some x
    | _ -> None

let rec delete (a, xs) =
    match xs with
    | x :: xs when x = a -> xs
    | x :: xs -> x :: delete (a, xs)
    | _ -> []

let rec sort xs =
    match minimum xs with
    | Some m -> m :: sort (delete (m, xs))
    | None -> []