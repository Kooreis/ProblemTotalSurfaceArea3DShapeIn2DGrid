Here is a TypeScript solution for the problem:

```typescript
class Grid {
    grid: number[][];

    constructor(grid: number[][]) {
        this.grid = grid;
    }

    calculateSurfaceArea(): number {
        let total = 0;
        for (let i = 0; i < this.grid.length; i++) {
            for (let j = 0; j < this.grid[0].length; j++) {
                if (this.grid[i][j] > 0) {
                    total += this.grid[i][j] * 4 + 2;
                    if (i > 0) total -= Math.min(this.grid[i][j], this.grid[i - 1][j]) * 2;
                    if (j > 0) total -= Math.min(this.grid[i][j], this.grid[i][j - 1]) * 2;
                }
            }
        }
        return total;
    }
}

let grid = new Grid([[1, 2], [3, 4]]);
console.log(grid.calculateSurfaceArea());
```

This solution assumes that the 2D grid represents a 3D shape where each cell value represents the height of a column at that position. The surface area of each column is calculated as 4 * height + 2 (for the top and bottom faces), and then the overlapping areas between adjacent columns are subtracted.