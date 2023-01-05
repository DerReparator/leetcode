fn main() {
    println!("Hello, world!");
}

pub fn average(mut salary: Vec<i32>) -> f64 {
    salary.sort();
    
    let mut sum: i32 = 0;

    for i in 1..salary.len()-1 {
        sum += salary[i];
    }

    return sum as f64 / (salary.len() - 2) as f64;
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test_average_01() {
        let input: Vec<i32> = vec![4000, 1000, 3000, 2000];
        let expected: f64 = 2500.0;

        assert_eq!(expected, average(input));
    }

    #[test]
    fn test_average_02() {
        let input: Vec<i32> = vec![1000, 2000, 3000];
        let expected: f64 = 2000.0;

        assert_eq!(expected, average(input));
    }
}
