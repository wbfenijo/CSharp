import ast

def parse_input_file(filename):
    with open(filename, "r") as f:
        content = f.read().strip().splitlines()
    matrices = [ast.literal_eval(line.strip()) for line in content if line.strip()]
    return matrices

def min_danger_path(matrix):
    n, m = len(matrix), len(matrix[0])
    dp = [[0]*m for _ in range(n)]
    dp[0][0] = matrix[0][0]

    for i in range(1, n):
        dp[i][0] = dp[i-1][0] + matrix[i][0]
    for j in range(1, m):
        dp[0][j] = dp[0][j-1] + matrix[0][j]

    for i in range(1, n):
        for j in range(1, m):
            dp[i][j] = matrix[i][j] + min(dp[i-1][j], dp[i][j-1])

    path = [(n-1, m-1)]
    i, j = n-1, m-1
    while i > 0 or j > 0:
        if i == 0:
            j -= 1
        elif j == 0:
            i -= 1
        else:
            if dp[i-1][j] < dp[i][j-1]:
                i -= 1
            else:
                j -= 1
        path.append((i, j))
    path.reverse()

    return dp[-1][-1], path

if __name__ == "__main__":
    matrices = parse_input_file("CG25task4_input.txt")
    for matrix in matrices:
        total_danger, path = min_danger_path(matrix)
        print(total_danger)
        for coord in path:
            print(f"[{coord[0]}, {coord[1]}]")
        print()
