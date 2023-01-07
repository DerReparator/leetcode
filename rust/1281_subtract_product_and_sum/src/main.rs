fn main() {
    println!("Hello, world!");
}

fn digitize_int(n: i32) -> Vec<i32> {
    let mut digits: Vec<i32> = Vec::new();
    let mut number = n;

    while number > 0 {
        digits.push(number % 10);
        number /= 10;
    }

    return digits;
}

pub fn subtract_product_and_sum(n: i32) -> i32 {
    let digits: Vec<i32> = digitize_int(n);

    let product: i32 = digits.iter().product();
    let sum: i32 = digits.iter().sum();

    return product - sum;
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn ex01() {
        let input: i32 = 234;
        let expected: i32 = 15;

        assert_eq!(expected, subtract_product_and_sum(input));
    }

    #[test]
    fn ex02() {
        let input: i32 = 4421;
        let expected: i32 = 21;

        assert_eq!(expected, subtract_product_and_sum(input));
    }
}
