var ViewModel = function() {
    var self = this;
    self.books = ko.observableArray();
    self.error = ko.observable();

    var booksUri = '/api/books/';

    function ajaxHelper(uri, method, data) {
        self.error('');
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data: data ? JSON.stringify(data) : null
        }).fail(function(jqXHR, textStatus, errorThrown) {
            self.error(errorThrown);
        });
    }

    function getAllBooks(parameters) {
        ajaxHelper(booksUri, 'GET').done(function(data) {
            self.books(data);
        });
    }

    getAllBooks();
};

ko.applyBindings(new ViewModel());
self.detail = ko.observable();

self.getBookDetail = function (item) {
    ajaxHelper(booksUri + item.Id, 'GET').done(function (data) {
        self.detail(data);
    });
}
self.categories = ko.observableArray();
self.newBook = {
    Category: ko.observable(),
    Author: ko.observable(),
    Title: ko.observable(),
    ISBN: ko.observable()
}

var categoriesUri = '/api/categories'

function getCategories(parameters) {
    ajaxHelper(categoriesUri, 'GET').done(function(data) {
        self.categories(data);
    });
}

self.addBook = function(formElement) {
    var book = {
        CategoryId: self.newBook.Category().Id,
        Author: self.newBook.Author(),
        Title: self.newBook.Title(),
        ISBN: self.newBook.ISBN()
    };
    ajaxHelper(booksUri, 'POST', book).done(function(item) {
        self.books.push(item);
    });
}

getCategories();