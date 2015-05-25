
QUnit.test("new ProbabilityCalculatorViewModel adds properties", function () {
	var probabilityCalculatorViewModel = new ProbabilityCalculatorViewModel();

	ok(ko.isObservable(probabilityCalculatorViewModel.value1), "value1 should be an observable property");
	ok(ko.isObservable(probabilityCalculatorViewModel.value2), "value2 should be an observable property");
	ok(ko.isObservable(probabilityCalculatorViewModel.result), "result should be an observable property");
});

QUnit.test("calculateCombinedWith calculates and sets result", function () {
	var probabilityCalculatorViewModel = new ProbabilityCalculatorViewModel();

	//set value 1 and value 2
	probabilityCalculatorViewModel.value1(0.5);
	probabilityCalculatorViewModel.value2(0.5);

	// run calculateCombinedWith
	probabilityCalculatorViewModel.calculateCombinedWith();

	// Verify result
	equal(probabilityCalculatorViewModel.result(), 0.25, "calculateCombinedWith is not returning the correct value");
});

QUnit.test("calculateEither calculates and sets result", function () {
	var probabilityCalculatorViewModel = new ProbabilityCalculatorViewModel();

	//set value 1 and value 2
	probabilityCalculatorViewModel.value1(0.5);
	probabilityCalculatorViewModel.value2(0.5);

	// run calculateCombinedWith
	probabilityCalculatorViewModel.calculateEither();

	// Verify result
	equal(probabilityCalculatorViewModel.result(), 0.75, "calculateCombinedWith is not returning the correct value");
});