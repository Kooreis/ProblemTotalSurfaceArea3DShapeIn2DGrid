```cpp
#include <iostream>
#include <vector>

using namespace std;

int surfaceArea(vector<vector<int>>& grid) {
    int n = grid.size();
    int m = grid[0].size();
    int area = 0;
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            if (grid[i][j]) {
                area += grid[i][j] * 4 + 2;
                if (i > 0) area -= min(grid[i][j], grid[i - 1][j]) * 2;
                if (j > 0) area -= min(grid[i][j], grid[i][j - 1]) * 2;
            }
        }
    }
    return area;
}

int main() {
    int n, m;
    cin >> n >> m;
    vector<vector<int>> grid(n, vector<int>(m));
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            cin >> grid[i][j];
        }
    }
    cout << surfaceArea(grid) << endl;
    return 0;
}
```