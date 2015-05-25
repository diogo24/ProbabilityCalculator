var ProbabilityCalculatorViewModel = function() {
	var self    = this;
	self.value1 = ko.observable();
	self.value2 = ko.observable();
	self.result = ko.observable();

	self.calculateCombinedWith = function () {
		var result = self.CombinedWith();
		self.result(result);

		self.saveProbability('CombinedWith');
		return result;
	};

	self.calculateEither = function () {
		var result = self.Either();
		self.result(result);

		self.saveProbability('Either');
		return result;
	};
};

ProbabilityCalculatorViewModel.prototype.saveProbability = function (type) {
	var self = this;

	var probability = {
		value1: self.value1(),
		value2: self.value2(),
		result: self.result(),
		type: type,
		created: moment.utc().format()
	};

	var uri = 'api/probability/save';

	$.post(uri, probability,'json')
          .done(function (data) {
          	var probability = data;
          });
};

ProbabilityCalculatorViewModel.prototype.CombinedWith = function () {
	var self = this;
	return parseFloat(self.value1()) * parseFloat(self.value2());
};

ProbabilityCalculatorViewModel.prototype.Either = function () {
	var self = this;
	return parseFloat(self.value1()) + parseFloat(self.value2()) - self.CombinedWith();
};
