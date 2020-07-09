# Sorting Api

## How to run the project

* navigate to SortApi folder
* run ```dotnet run```

## Available routes

* ```GET``` ```https://localhost:5001/sort/array``` with query parameter `numbersToSort`

For example request: ```https://localhost:5001/sort/array?numbersToSort=3,6,8,10,5,7,3,2```

response: 

```
{ 
    "message": "Sorted array is saved on your Desktop in results.txt file.",
    "before": "3,6,8,10,5,7,3,2",
    "after": "2,3,3,5,6,7,8,10" 
}

```

Results can also be found in results file located in the Desktop.

* ```GET``` ```https://localhost:5001/sort/file``` with query parameter ```fileName```

For example 

On desktop there is a file called test with `5,6,9,8,1,2,5,8,9,1,3,5` inside of it.

For example request: ```https://localhost:5001/sort/file/?fileName=test```

response: 

```
{
    "message": "File was sucessfully read and results are saved on your Desktop in results.txt file.",
    "before": "5,6,9,8,1,2,5,8,9,1,3,5",
    "after": "1,1,2,3,5,5,5,6,8,8,9,9"
}

```


Results can also be found in results file located in the Desktop.

## How to run tests

* navigate to NUnitSortApiTest folder
* run `dotnet test`