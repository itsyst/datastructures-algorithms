const isMonotonic = (array) => {
        if (array.length <= 2)
            return true;

        increasing = true;
        decreasing = true;

        for (let i = 1; i < array.length; i++) {
            if (array[i - 1] > array[i])
                increasing = false;

            if (array[i - 1] < array[i])
                decreasing = false;
        }

        return increasing || decreasing;
}
 

const array = [-1, -5, -10, -1100, -1100, -1101, -1102, -9001];
const result = isMonotonic(array);
console.log(result);
   
 