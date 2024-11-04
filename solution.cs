Here is a JavaScript solution for the problem:

```javascript
function surfaceArea(grid) {
    let area = 0;
    let n = grid.length;

    for(let i=0; i<n; i++) {
        for(let j=0; j<n; j++) {
            let cell = grid[i][j];
            if(cell > 0) {
                area += cell * 4 + 2;
                if(i > 0) area -= Math.min(cell, grid[i-1][j]) * 2;
                if(j > 0) area -= Math.min(cell, grid[i][j-1]) * 2;
            }
        }
    }

    return area;
}

console.log(surfaceArea([[1,2],[3,4]]));
console.log(surfaceArea([[1,0],[0,2]]));
console.log(surfaceArea([[1,1,1],[1,0,1],[1,1,1]]));
console.log(surfaceArea([[2,2,2],[2,1,2],[2,2,2]]));
```

This console application calculates the total surface area of a 3D shape represented in a 2D grid. The surface area of each cell in the grid is calculated by multiplying the cell value by 4 and adding 2 (for the top and bottom faces). If there are cells adjacent to the current cell, the overlapping area is subtracted from the total surface area. The overlapping area is calculated as the minimum value of the current cell and the adjacent cell multiplied by 2. The total surface area is the sum of the surface areas of all cells in the grid.