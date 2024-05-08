package model;

public class NumberAdder {

		private int firstNum;
		private int secondNum;
		private int sum;
		
		public NumberAdder() {
			super();
		}
		public NumberAdder(int first, int second) {
			super();
			this.firstNum = first;
			this.secondNum = second;
			setFirstNum(first);
			setSecondNum(second);
			setSum();
		}
		public int getFirstNum() {
			return firstNum;
		}
		public void setFirstNum(int firstNum) {
			this.firstNum = firstNum;
		}
		public int getSecondNum() {
			return secondNum;
		}
		public void setSecondNum(int secondNum) {
			this.secondNum = secondNum;
		}
		public int getSum() {
			return sum;
		}
		public void setSum() {
			sum = add(firstNum, secondNum);
		}
		
		public int add(int first, int second) {
			return first + second;
		}
		
		public String printResult() {
			return "Sum of " + firstNum + " and " + secondNum + " is " + sum;
		}
}
