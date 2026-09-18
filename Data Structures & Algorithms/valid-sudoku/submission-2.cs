public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[][] buckets = new HashSet<char>[3][];
        for(int i = 0; i < 3; i++){
            buckets[i] = new HashSet<char>[3];
            for(int j = 0; j < 3; j++){
                buckets[i][j] = new HashSet<char>();
            }
        }
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        for(int i = 0; i < 9; i++){
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
        }
        for(int x = 0; x < 9; x++){
            for(int y = 0; y < 9; y++){
                if( board[x][y] != '.' &&
                    (!buckets[bucketId(x)][bucketId(y)].Add(board[x][y]) ||
                    !rows[x].Add(board[x][y]) ||
                    !cols[y].Add(board[x][y]))){
                    return false;
                } 
            }
        }
        return true;
    }

    private int bucketId(int num){
        double dec = num / 3;
        return (int)Math.Floor(dec);
    }
}
