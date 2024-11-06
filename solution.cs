for(let i=0; i<n; i++) {
        for(let j=0; j<n; j++) {
            let cell = grid[i][j];
            if(cell > 0) {
                area += cell * 4 + 2;
}