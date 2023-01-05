fn main() {
    println!("Hello, world!");
}

pub fn hamming_weight (n: u32) -> i32 {
    let mut no_of_1_bits: i32 = 0;

    for i in 0..32 {
        let mask: u32 = 1 << i;
        if n & mask > 0 {
            no_of_1_bits += 1;
        }
    }

    return no_of_1_bits;
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test_hamming_weight_ex01() {
        let input: u32 = 0b00000000000000000000000000001011;
        let expected: i32 = 3;

        assert_eq!(expected, hamming_weight(input));
    }

    #[test]
    fn test_hamming_weight_ex02() {
        let input: u32 = 0b00000000000000000000000010000000;
        let expected: i32 = 1;

        assert_eq!(expected, hamming_weight(input));
    }

    #[test]
    fn test_hamming_weight_ex03() {
        let input: u32 = 0b11111111111111111111111111111101;
        let expected: i32 = 31;

        assert_eq!(expected, hamming_weight(input));
    }
}
