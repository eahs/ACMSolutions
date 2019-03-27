import java.time.LocalDateTime;
import java.time.LocalTime;
import java.time.temporal.ChronoUnit;
import java.time.temporal.Temporal;
import java.time.temporal.TemporalAmount;
import java.time.temporal.TemporalUnit;
import java.util.*;

public class Horn {
	public static void main (String[] args) {
		Scanner scan = new Scanner(System.in);
		String input, result;
		int[] first, second;
		int firstSec, secondSec, interval, hours, mins, secs;

		System.out.print("Clock time: ");
		input = scan.nextLine();
		first = splitIntoInt(input, " ");

		System.out.print("Clock time: ");
		input = scan.nextLine();
		second = splitIntoInt(input, " ");

		firstSec = toSeconds(first);
		secondSec = toSeconds(second);

		interval = Math.abs(firstSec-secondSec);
		hours = interval/3600;
		interval = interval - hours*3600;
		mins = interval/60;
		secs = interval - mins*60;
		result = tFormat(hours) + ":" + tFormat(mins) +":" + tFormat(secs);
		System.out.println(result);
	}

	public static int[] splitIntoInt(String str, String splitStr) {
		String[] nums = str.split(splitStr);
		int[] arr = new int[nums.length];

		for (int i = 0; i < nums.length; i++) {
			arr[i] = Integer.parseInt(nums[i]);
		}

		return arr;
	}

	public static int toSeconds(int[] time) {
		int seconds = 0;

		seconds += time[0]*3600;
		seconds += time[1]*60;
		seconds += time[2];

		return seconds;
	}

	public static String tFormat (int n) {
		String str = Integer.toString(n);

		if (str.length() == 0) {
			str = "00";
		} else if (str.length() == 1) {
			str = "0" + n;
		}

		return str;
	}
}
