int countTriangles(int[] x, int[] y) 
{
    int len = x.Length;
    int answer = 0;
    for (int i=0; i<len; i++){
        for (int j=i+1; j<len; j++){
            for (int k=j+1; k<len; k++) {
                int x1 = x[i] - x[j], y1 = y[i] - y[j];
                int x2 = x[i] - x[k], y2 = y[i] - y[k];
                if (x1*y2 != x2*y1){
                   answer++;  
                }          
            }      
        }     
    }
    return answer;
}
