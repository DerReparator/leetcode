fn main() {
    println!("Hello, world!");
}

pub fn count_odds(low: i32, high: i32) -> i32 {
    let diff = high - low;
    let mut no_of_odds = 0;

    if low % 2 == 1 {
        no_of_odds += 1;
        no_of_odds += diff / 2;
    } else {
        no_of_odds += (diff + 1) / 2;
    }

    return no_of_odds;
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn count_odds_ex_01() {
        let low = 3;
        let high = 7;
        let expected = 3;

        assert_eq!(expected, count_odds(low, high));
    }


    #[test]
    fn count_odds_ex_02() {
        let low = 8;
        let high = 10;
        let expected = 1;

        assert_eq!(expected, count_odds(low, high));
    }


    #[test]
    fn count_odds_ex_03() {
        let low = 14;
        let high = 17;
        let expected = 2;

        assert_eq!(expected, count_odds(low, high));
    }

    #[test]
    fn count_odds_ex_own01() {
        let low = 3;
        let high = 3;
        let expected = 1;

        assert_eq!(expected, count_odds(low, high));
    }
}
